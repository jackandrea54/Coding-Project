from flask import Flask, redirect, render_template, url_for, request,session,jsonify,json
import psycopg2 as pg
from markupsafe import escape
import sys
import os

# sys.path.append(os.path.abspath('constants'));

import constants.postgre_cmd as cmd
import constants.default as default

import lib.postgre as postgreSQL



app = Flask(__name__)

app.secret_key = b'_5#y2L"F4Q8z\n\xec]/';

dtbs = postgreSQL.postgresDB(
    user='postgres',
    pwd='12345',
    host='127.0.0.1',
    port='5432',
    database='postgres',
)

@app.route('/')
def index () :
    return redirect('http://127.0.0.1:5000/homepage')


@app.route('/homepage')
def homepage ():
    return render_template('homepage.html')


@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':  
        user_data = None
        username = request.form['username'];
        pwd = request.form['pwd']
        print(username,pwd);
        conn = dtbs.createConnection();
        try:
            cur = conn.cursor();
            cur.execute('''
        SELECT * FROM USERS WHERE username = %s AND pwd = %s
    ''',(username,pwd,))
            user_data = cur.fetchone()

            print(user_data);
            cur.close();
        except (Exception, pg.Error) as error :
            print(error);
            # error when get user data 

        if (user_data == None):
            print('Not have acc')
            return redirect(url_for('login'));
            # redirect to signup
        
        # api
        session['id'] = user_data[0];

        dtbs.closeConnection();
        return redirect('http://127.0.0.1:5000/timetable'); 
    else:
        return render_template('login.html')

@app.route('/logout')
def logout():
    # remove the username from the session if it's there
    session.pop('id', None)
    return redirect(url_for('homepage'))

def convert_to_weekly_table (raw_data):
    table = [];
    for tm in range(7):
        table.append({});
        for i in raw_data:
            table[tm][i[1]] = {}

    for tm in range(7):
        for i in raw_data:
            # if (i[tm+2] != None):
                table[tm][i[1]][i[0]] = i[tm+2];
    
    return table

def convert_to_daily_table (raw_data):
    table = [];
    for i in raw_data:
        obj = {};
        for k,v in i.items():
            obj[k] = v;
        table.append(obj);
    return table;

def convert_to_raw_data (table,table_type):
    if (table_type == 0):
        raw_data = [];

        for tm in range(7):
            for k,v in table[tm].items():
                for k1,v1 in v.items():
                    is_exist = False;
                    for i in raw_data:
                        if (i[0] == k1 and i[1] == k):
                            i[tm+2] = v1;
                            is_exist = True;
                            break;
                        
                    if not is_exist:
                        raw_data.append([k1,k,None,None,None,None,None,None,None]);
                        raw_data[-1][tm+2] = v1;
                        
        return raw_data
    elif table_type == 1:
        order = cmd.daily_table_cmd['index'];
        raw_data = [];

        for i in raw_data:
            arr = [None,None,None,None,None,None,None];
            for k,v in i.items():
                arr[order[k]] = v;
            raw_data.append(arr);

        return raw_data;

def loadTable (table_id):
    table = [];
    conn = dtbs.createConnection();
    try:
        cur = conn.cursor();
        
        cur.execute('''SELECT act_index FROM {} WHERE type = 'table_type' '''.format(table_id))

        table_type = cur.fetchone()[0];
        print(table_type)

        # weekly
        if (table_type == 0):
            cur.execute(cmd.weekly_table_cmd['load_table'].format(table_id))
            raw_data = cur.fetchall();
            
            print(raw_data);

            table = convert_to_weekly_table(raw_data);

            print(table);
        elif (table_type == 1):
            cur.execute(cmd.daily_table_cmd['load_table'].format(table_id))
            raw_data = cur.fetchall();

            table = convert_to_daily_table(raw_data);

        cur.close();
    except (Exception, pg.Error) as error :
        print(error);
        # error when get user data 
    dtbs.closeConnection();

    return table;
    # load to html (AJAX)


def generateTableKey ():
    return 'keydsasad';


def createTable (user_id,table_type,indx,table_id=None): 
    tbl_cmd = cmd.cmd[table_type]
    if table_id == None:
        table_id = generateTableKey();
    conn = dtbs.createConnection();
    try:
        cur = conn.cursor();
        cur.execute(tbl_cmd['create_table'].format(table_id));

        cur.execute('''INSERT INTO {} (type,act_index) values ('table_type','{}')'''.format(table_id,table_type));
        cur.execute('''INSERT INTO {} (type,act_index) values ('user_id',{})'''.format(table_id,user_id));
        cur.execute('''INSERT INTO {} (type,act_index) values ('index',{})'''.format(table_id,indx));
        conn.commit();
        cur.close();
    except (Exception, pg.Error) as error :
        print(error);
        # error when get user data 
    dtbs.closeConnection();
    return table_id

# weekly only
def updateTable (new_table,table_id,indx):
    raw_data = convert_to_raw_data(new_table,0);
    print(raw_data);
    conn = dtbs.createConnection();
    try:
        cur = conn.cursor();
        for i in raw_data:
            print(i);
            cur.execute('''SELECT * FROM {} WHERE type = '{}' AND act_index = {}'''.format(table_id,i[0],i[1]))
            if cur.fetchone() == None:
                cmd = '''
                    INSERT INTO {}(type,act_index,Sun,Mon,Tu,We,Th,Fr,Sa) values('{}',{},'{}','{}','{}','{}','{}','{}','{}')
                '''
                cur.execute(cmd.format(table_id,i[0],i[1],i[2],i[3],i[4],i[5],i[6],i[7],i[8]));
            else:
                cmd = '''
                    UPDATE {}  
                    SET type = '{}',
                        act_index = {},
                        Sun = '{}',
                        Mon = '{}',
                        Tu = '{}',
                        We = '{}',
                        Th = '{}',
                        Fr = '{}',
                        Sa = '{}'
                    WHERE type = '{}' AND act_index = {}
                '''
                cur.execute(cmd.format(table_id,i[0],i[1],i[2],i[3],i[4],i[5],i[6],i[7],i[8],i[0],i[1]));
        conn.commit();
        cur.close();
    except (Exception, pg.Error) as error :
        print(error);

    dtbs.closeConnection();

@app.route('/timetable',methods=['GET','POST']) 
def timetable ():
    if not 'id' in session:
        return redirect(url_for('login'));
    
    return render_template('/timetable/weekly.html');

@app.route('/getUserID')
def getUserID ():
    if not 'id' in session:
        return redirect(url_for('login'));
    user_data = None
    conn = dtbs.createConnection();
    try:
        cur = conn.cursor();
        cur.execute('''SELECT * FROM users WHERE id = %s''',(session['id'],))
        user_data = cur.fetchone()

        print(user_data);
        cur.close();
    except (Exception, pg.Error) as error :
        print(error);
        # error when get user data 

    if (user_data == None):
        print('Not have acc')
        return redirect(url_for('login'));
        # redirect to signup
    dtbs.closeConnection();
    return jsonify(user_data);

@app.route('/getTable/<string:table_id>')
def getTable (table_id):
    table = loadTable (table_id);
    res = app.response_class(
        response= json.dumps(table),
        status=200,
        mimetype='application/json',
    )
    return res;

@app.route('/update_table',methods = ['POST'])
def update_table ():


    # print(request.get_json());
    userInfo = request.get_json()['userInfo'];
    table = request.get_json()['data'];
    print(userInfo[1]);

    updateTable(table,userInfo[1],1);


    # data = request.form['data'];
    # print(data);
    return 'HI';

@app.route('/script/<string:script_name>')
def script(script_name):
    if script_name == 'weekly.js':
        return render_template('/timetable/weekly.js')

# always run when build (for debugging) 
with app.test_request_context():
    pass
    # print(url_for('hello_world'))
    # print(url_for('sum',x=1,y=2))
    # print(url_for('login', next='/'))
    # print(url_for('profile', username='John Doe'))

if __name__ == '__main__':
    app.run();  