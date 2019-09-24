

function setNotification(notificationDate, notificationCallback) {
    var currentDate = new Date();
    var date = new Date(notificationDate);
    var interval = date - currentDate;

    if (interval == 0)
        alert('List of the Notice Description Date.')
        //window.setTimeout(function () { notificationCallback(item) }, interval); //notificationCallback = showModal()
    
}