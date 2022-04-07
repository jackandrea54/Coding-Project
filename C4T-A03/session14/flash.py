from flask import Flask, redirect, render_template, request
import psycopg2
app = Flask(__name__)


@app.route('/')
def index():

    src_string = 'postgresql://{}:{}@localhost:5432/{}'.format('postgres','123','postgres')
    conn = psycopg2.connect(src_string)

    sql = '''
            CREATE TABLE if not exists answers
            (
                id SERIAL PRIMARY KEY ,
                answer1 VARCHAR ,
                answer2 VARCHAR ,
                platform VARCHAR ,
                browser VARCHAR 
            )
            '''
    cursor = conn.cursor()
    cursor.execute(sql)
    conn.commit()
    conn.close()
    return 'mindvd'

@app.route('/sample')
def test():
    return 'nam'

@app.route('/say_hi')
def say_hi_everyone(name):
    arg_1 = request.arg.get('name', '')
    return 'xin chao {}'.format(name)

@app.route('/add/<int:x>/<int:y>')
def sum_total(x, y):
    total = x + y
    return str(total)

@app.route('/redirect')
def test_redirect():
    # return redirect("/sample")
    return redirect("https://www.google.com.vn/?hl=vi")

@app.route('/web', methods=['GET', 'POST'])
def homepage():
    if request.method == "GET":
        return render_template("demo.html")

    elif request.method == 'POST':
        form = request.form
        answer1 = form["question1_name"]
        answer2 = form["question2_name"]
        print(answer1, answer2)
        
        user_agent = request.user_agent
        print(user_agent.platform)
        print(user_agent.version)
        print(user_agent.browser)
        print(user_agent.language)
        print(request.remote_addr)

        src_string = 'postgresql://{}:{}@localhost:5432/{}'.format('postgres','123','postgres')
        conn = psycopg2.connect(src_string)

        sql = '''
                insert into answers (answer1, answer2, platform, browser) values ('{}', '{}', '{}', '{}');
                '''.format(answer1, answer2, user_agent.platform, user_agent.browser)
        cursor = conn.cursor()
        cursor.execute(sql)
        conn.commit()
        conn.close()

    return render_template('demo.html')


if __name__ == '__main__':
    app.run()
