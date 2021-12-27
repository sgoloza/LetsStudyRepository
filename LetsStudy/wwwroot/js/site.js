// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function SetValue( messageType) {
    if (messageType == 'ZoomMeeting')
        document.getElementById("BookingDateMessage2").value = 'ZoomMeeting';
    else if (messageType == 'ModulesNeedHelpFor')
        document.getElementById("BookingDateMessage1").value = 'ModulesMeeting';
    else if (messageType == 'DropNote') {
        document.getElementById("BookingDateMessage4").value = 'Note';
    }
      
}
function NavBarLinkCliked(clickedLink) {
    document.getElementById(clickedLink).style.backgroundColor = "Black";
}