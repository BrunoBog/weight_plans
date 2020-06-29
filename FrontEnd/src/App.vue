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
  width: 100%;
  height: 100%;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  background-color: #e5e5e5;
}
.hero {
  height: 50%;
}
</style>
