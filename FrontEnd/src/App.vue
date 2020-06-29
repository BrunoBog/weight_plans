<template>
  <div id="app">
    <Hero class="hero" />
    <resume />
  </div>
</template>

<script>
import resume from "./pages/Resume.vue";
import Hero from "./components/Hero.vue";

export default {
  name: "App",
  components: {
    resume,
    Hero
  }
};
</script>

<style>
* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}
body{
  width: 100%;
  max-height: 100%;
  background-color: #F1FAEE;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  background-color: #F1FAEE;
}
.hero {
  min-height: 50%;
}
</style>
