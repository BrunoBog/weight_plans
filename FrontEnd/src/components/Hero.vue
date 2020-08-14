<template>
  <div class="boxHero">
    <div class="header"></div>
    <div class="principal">{{weight}} Kg</div>
    <div class="sub">{{bf}}% Bf</div>
    <div class="footer"></div>
  </div>
</template>

<script>
export default {
  name: "Hero",
  props: ["actual_weight", "actual_bf"],
  data() {
    return {
      //TODO colocar esses caras no state para trocar quando enviar um novo peso
      weight: this.actual_weight,
      bf: this.actual_bf
    };
  },
  methods:{
    async get_values() {
      try {
        let r = await this.$http({
          url: this.$config.base_url + "v1/weight/Last",
          method: 'GET'
          })
          this.weight = r.data.weightValue
          this.bf = r.data.bodyFatValue
        // this.$forceUpdate()
      } catch (error) {
        console.log(error)
      }
    },
  },
   beforeMount() {
    this.get_values()
  }
};
</script>

<style>
.boxHero {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  min-height: 350px;
  color: #e96544;
  background-image: linear-gradient(to right, #1d3557, #457b9d, #e63946);
}

.principal{
    font-size: 99px;
}
.sub {
  font-size: 30px;
}
</style>