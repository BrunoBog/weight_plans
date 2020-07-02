<template>
  <div id="app">
    <Hero class="hero" />
    <resume />
  </div>
</template>

<script>
import resume from "../views/Resume.vue";
import Hero from "../components/Hero.vue";

export default {
  name: "Home",
  components: {
    resume,
    Hero
  }
};
</script>

<style>
.hero {
  min-height: 380px;
}
</style>
