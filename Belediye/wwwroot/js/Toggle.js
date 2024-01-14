        function ToggleSearch() {
            var x = document.getElementById("searchbtn");
            if (x.style.display === "flex") {
                x.style.display = "none";
            } else {
                x.style.display = "flex";
                x.style.justifyContent = "center";
                x.style.marginTop = "10px";
            }
}
function openNav() {
    document.getElementById("sideBar").style.width = "250px";
}

function closeNav() {
    document.getElementById("sideBar").style.width = "0";
}