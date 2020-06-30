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
body {
  width: 100%;
  height: 100%;
  max-height: 100%;
  background-color: #f1faee;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  background-color: #f1faee;
  height: 100%;
}
.hero {
  min-height: 380px;
}
</style>
