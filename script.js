// script.js

function register() {
    const email = document.getElementById("register-email").value;
    const password = document.getElementById("register-password").value;

    if (!email || !password) {
        alert("Please enter both email and password.");
        return;
    }

    fetch("http://localhost:5163/auth/register", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({ email, password })
    })
    .then(response => response.json())
    .then(data => {
        console.log("API Response:", data);
        if (data.success) {
            alert(`Message: ${data.message}\nWelcome, ${data.data.email}`);
            window.location.href = "login.html";
        } else {
            alert(`Error: ${data.message}`);
        }
    })
    .catch(error => {
        console.error("Error:", error);
        alert("Error: " + error.message);
    });
}

function login() {
    const email = document.getElementById("login-email").value;
    const password = document.getElementById("login-password").value;

    if (!email || !password) {
        alert("Please enter both email and password.");
        return;
    }

    fetch("http://localhost:5163/auth/login", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({ email, password })
    })
    .then(response => response.json())
    .then(data => {
        console.log("API Response:", data);
        if (data.success) {
            alert("Login Successfull");
            localStorage.setItem("token", data.data.token); // Store token
            window.location.href = "greetings.html";
        } else {
            alert(`Error: ${data.message}`);
        }
    })
    .catch(error => {
        console.error("Error:", error);
        alert("Error: " + error.message);
    });
}
function fetchGreetings() {
    const token = localStorage.getItem("token"); // Retrieve JWT token

    fetch("https://localhost:7130/HelloGreeting/Greetings", {
        method: "GET",
        headers: { 
            "Authorization": `Bearer ${token}`,
            "Accept": "application/json"
        }
    })
    .then(response => {
        if (!response.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`);
        }
        return response.json();  // Ensure JSON parsing
    })
    .then(data => {
        console.log("API Response:", data); // Debugging log

        if (!data || !data.data) {
            throw new Error("Invalid API response format");
        }

        const list = document.getElementById("greetings-list");
        list.innerHTML = ""; // Clear previous data

        data.data.forEach(greeting => {
            const li = document.createElement("li");
            li.textContent = `ID: ${greeting.id}, Message: ${greeting.message}`;
            list.appendChild(li);
        });
    })
    .catch(error => console.error("Error fetching greetings:", error));
}

