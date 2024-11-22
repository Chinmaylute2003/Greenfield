function setData() {
    const email = document.getElementById("txtEmail").value;
    const firstName = document.getElementById("txtFirstName").value;
    const lastName = document.getElementById("txtLastName").value;
    let user = {
        email : email,
        firstName:firstName,
        lastName: lastName  
    }
    user = JSON.stringify(user)
    sessionStorage.setItem("user", user)
}

function getData() {
    let userData = sessionStorage.getItem("user");
    userData = JSON.parse(userData);
    const labelRef = document.getElementById("labelResult");
    labelRef.innerHTML = `<table class="table table-bordered">
        <tr>
            <th>Email</th>
            <td>${userData.email}</td>
        </tr>
        <tr>
            <th>First Name</th>
            <td>${userData.firstName}</td>
        </tr>
        <tr>
            <th>Last Name</th>
            <td>${userData.lastName}</td>
        </tr>
    </table>`



}