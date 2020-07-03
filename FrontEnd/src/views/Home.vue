<template>
  <div id="app">
    <Hero class="hero" actual_weight="100" actual_bf="30" />
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
      lastWeight: Number,
      lastBf: Number
    };
  },
  methods: {
    async get_values() {
      debugger
      try {
        let size = await this.$http.get(this.$config.base_url + "v1/weight");
        console.log(size)
      } catch (error) {
        console.log(error);
      }
    },
    async get_last_weight_and_last_bf() {

    }
  },
  mounted: () => {
    this.get_values()
  },
};
</script>

<style>
.hero {
  min-height: 380px;
}
</style>
