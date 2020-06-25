<template>
  <div class="card">
      <input  type="text" name="field1" placeholder="Actual Wheight" />
      <DatePicker />
    <Butt class="but" v-on: On_click="On_click" Label="Send" />
  </div>
</template>

<script>
import Butt from "../components/button.vue";
import DatePicker from "../components/datepicker.vue";
export default {
  name: "weightCard",
  components: {
    Butt,
    DatePicker
  },
  data() {
    return {
      weightValue: 0,
      data: new Date(2016, 9, 16)
    };
  },
  methods: {
    async On_click() {
      console.log("Clicou Danado");
    }
  }
};
</script>

<style scoped>
.card {
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  background-color: #465775;
  max-width: 350px;
  max-height: 170px;
  border: none;
  border-radius: 25px;
}
.card img {
  max-width: 20px;
  max-height: 20px;
}
.form{
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
}
.card input {
  max-width: 200px;
  max-height: 30px;
  margin-top: 10px;

  /* color: #06d6a0; */
  color: #ddd;
  border: none;
  border-bottom: 1px solid #048a81;
  background: transparent;
  font-family: "Open Sans Condensed", sans-serif;
  font-size: 14px;
  font-weight: bold;
}
.but {
  margin-bottom: 7px;
}
.picker {
  max-width: 100px;
  padding-left: 10px;
  max-height: 20px;
}
</style>