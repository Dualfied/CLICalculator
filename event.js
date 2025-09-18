const SignupButton = document.querySelector(".SignupButton");
const eyeicon = document.getElementById("eyeicon")
const PasswordBox = document.getElementById("passwordbox")
let NotificationContainer = document.querySelector(".NotifContainer")

SignupButton.onclick = function() {
    console.log("Button clicked")
}

eyeicon.onclick = function() {
    if (PasswordBox.type == "password") {
        PasswordBox.type = "text";
        eyeicon.src = "Icons/view.png"
    } else {
        PasswordBox.type = "password"
        eyeicon.src = "Icons/hide.png"
    }
}

function DisplayNotification() {
    let NotificationInstance = document.createElement("div")

    const Icon = document.createElement("img")

    const Status = document.createElement("p")
    Status.textContent = "[ State ]"
    Status.classList.add("NotificationStatus")

    const Info = document.createElement("p")
    Info.textContent = "Please fill in all the fields"
    Info.classList.add("Info")

    Icon.classList.add("NotifIcon")
    Icon.src = "Hide.png"
    NotificationInstance.classList.add("toast")
    NotificationContainer.appendChild(NotificationInstance)
    NotificationInstance.appendChild(Icon)
    NotificationInstance.appendChild(Status)
    NotificationInstance.append(Info)
    
    setTimeout(function() {NotificationInstance.remove();}, 6000)
}

