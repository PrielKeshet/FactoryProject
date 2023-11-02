
function HelloName() {
    let span = document.getElementById('SpanName');
    span.innerText = "Hello " + sessionStorage['UserFullName'];
}

async function OneLessAction() {

    let resp = await fetch('https://localhost:44336/api/User/' + sessionStorage['UserID']);
    let User = await resp.json();


    if (User.NumOfActions > 0) {
        sessionStorage['NumOfActions'] = User.NumOfActions - 1;
        console.log(sessionStorage['NumOfActions']);
        let obj = {
            FullName: User.FullName,
            UserName: User.UserName,
            Password: User.Password,
            NumOfActions: User.NumOfActions - 1
        }
        let request = {
            method: 'PUT',
            body: JSON.stringify(obj),
            headers: { 'Content-Type': 'application/json' }
        }
        let id = sessionStorage['UserID'];
        let resp2 = await fetch('https://localhost:44336/api/User/' + id, request);
        let Data = await resp2.json();
        console.log(Data);

    }
    else {
        LogOut();
    }

}
function LogOut() {
    sessionStorage.clear();
    location.href = 'Login.html';
}

async function MakeNewDate() {
    let d2 = new Date();
    let day2 = d2.getDate();
    let month2 = d2.getMonth() + 1;
    let year2 = d2.getFullYear();
    let NewDate = day2 + '/' + month2 + '/' + year2;
    localStorage.setItem('NewDate', NewDate);

    if (localStorage.getItem('LastDate') != localStorage.getItem('NewDate')) {
        let resp = await fetch('https://localhost:44336/api/User');
        let Users = await resp.json();
        Users.forEach(async user => {
            let obj = {
                FullName: user.FullName,
                UserName: user.UserName,
                Password: user.Password,
                NumOfActions: 30
            }
            let request = {
                method: 'PUT',
                body: JSON.stringify(obj),
                headers: { 'Content-Type': 'application/json' }
            }
            let resp = await fetch('https://localhost:44336/api/User/' + user.ID, request);
            let user2 = await resp.json();
            console.log(user2);
        });
        localStorage.setItem('LastDate', localStorage.getItem('NewDate'));
    }
    localStorage.removeItem('NewDate');
}


function GoHome() {
    location.href = 'HomePage.html';
}