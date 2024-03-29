@font-face {
  font-family: "Cinzel";
  src: url("Cinzel-VariableFont_wght.ttf") format("truetype");
}
* {
  user-select: none;
  margin: 0;
  padding: 0;
}

.mainpage {
  background-color: black;
  width: auto;
  height: 100vh;
  background-image: linear-gradient(to right, rgba(246, 116, 32, 0.2), transparent, rgba(47, 205, 252, 0.2));
}
.mainpage svg {
  position: absolute;
  top: 50vh;
}
.mainpage h1 {
  position: absolute;
  text-align: center;
  color: rgba(140, 140, 140, 0.3);
  margin-left: auto;
  left: 0;
  margin-right: auto;
  right: 0;
  top: 44vh;
  font-family: Cinzel, serif;
  font-weight: 500;
}
.mainpage .kolo {
  position: absolute;
  bottom: -2.8vh;
  margin-left: auto;
  margin-right: auto;
  left: 0;
  right: 0;
  width: 5vh;
  height: 5vh;
  border-radius: 5vh;
  box-shadow: 0px 0px 10px 5px rgba(140, 140, 140, 0.3), 0px 0px 10px 5px rgba(140, 140, 140, 0.3);
}
.mainpage nav {
  background-color: rgba(140, 140, 140, 0.3);
  width: auto;
  height: 6vh;
  display: flex;
}
.mainpage nav img {
  position: relative;
  top: 0.5vh;
  height: 5vh;
  left: 7.3%;
  margin-right: 15vh;
}
.mainpage nav .navelement {
  position: relative;
  height: 4vh;
  margin-left: 5vh;
  padding: 1vh;
  padding-bottom: 0vh;
  top: 0.5vh;
  background-color: transparent;
  transition: 1s;
}
.mainpage nav .navelement:hover {
  background-color: rgba(140, 140, 140, 0.3);
  cursor: pointer;
}
.mainpage nav .navelement h2 {
  font-size: 2.5vh;
}

/*# sourceMappingURL=style.cs.map */
