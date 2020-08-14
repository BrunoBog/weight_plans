<template>
  <div id="app">
    <Hero class="hero" :actual_weight=lastWeight :actual_bf=lastBf />
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
  },
  data() {
    return {
      weightSizes: [],
      BfSizes: [],
      lastWeight: 0,
      lastBf: 0
    };
  },
  methods: {
  },
  mounted() {
  },
  beforeMount() {
  }
};
</script>

<style>
.hero {
  min-height: 380px;
}
</style>
