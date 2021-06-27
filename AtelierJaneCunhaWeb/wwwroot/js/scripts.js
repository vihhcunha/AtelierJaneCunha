const buttonToggleMenu = document.getElementById("menu-toggle-button");
const navMenu = document.getElementById("nav-menu");

buttonToggleMenu.addEventListener("click", abrirFecharMenu);

function abrirFecharMenu() {
	if (navMenu.classList.contains("nav-menu-show")) {
		navMenu.classList.remove("nav-menu-show");
	}
	else {
		navMenu.classList.add("nav-menu-show");
	}
}