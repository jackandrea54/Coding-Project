const api_url1 = 'https://api.apify.com/v2/key-value-stores/ZsOpZgeg7dFS1rgfM/records/LATEST';
const api_url2 = 'https://api.apify.com/v2/key-value-stores/ZsOpZgeg7dFS1rgfM/records/LATEST';
function click1() {
    let dt = fetch(api_url1)
        .then(function (response) {
            return response.json();
        })
        .then(function (data) {
            console.log('Success:', data.detail);
            // Lấy ra số ca tử vong
            let deaths = data.detail.map((death) => {
                return `Số ca tử vong ở ${death.name} là ${death.death} `;
            });
            let deathsArr = [];
            deathsArr.push(deaths);
            console.log(deathsArr);
            // Lấy ra số ca nhiễm
            let cases = data.detail.map((cases) => {
                return `Số ca nhiễm ở ${cases.name} là ${cases.cases}`
            });
            let casesArr = [];
            casesArr.push(cases);
            console.log(casesArr);
            // Lấy ra số ca hồi phục
            let recoveries = data.detail.map((recovery) => {
                return `Số ca hồi phục ở ${recovery.name} là ${recovery.recovered} `
            });
            let recoveriesArr = [];
            recoveriesArr.push(recoveries);
            console.log(recoveriesArr);
        })
        .catch(function () {
            console.log('Lỗi');
        })
}
click1();
