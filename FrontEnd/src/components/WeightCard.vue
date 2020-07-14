<template>
  <div class="card">
    <input
      type="text"
      name="weight"
      placeholder="Actual Wheight"
      class="first_input"
      v-model="weightValue"
    />

    <input type="text" name="bf" placeholder="Actual bf" class="second_input" v-model="bfValue" />
    <DatePicker />
    <Butt class="but" label="Send" @On_click="On_click" />
  </div>
</template>

<script>
import Butt from "../components/button.vue";
import DatePicker from "../components/datepicker.vue";
import { mapActions, mapGetters } from "vuex";
export default {
  name: "weightCard",
  components: {
    Butt,
    DatePicker
  },
  data() {
    return {
      weightValue: 0.0,
      bfValue: 0.0
    };
  },
  methods: {
    ...mapActions(["printDate"]),
    ...mapGetters(["selectDate"]),
    On_click() {
      this.postWeight()
    },
    async postWeight() {
      let payload = {
        Day: this.selectDate(),
        WeightValue: parseFloat(this.weightValue),
        BodyFatValue: parseFloat(this.bfValue),
        Description: null,
        UserMail: "bog906@gmail.com"
      };
      try {
        await this.$http({
          url: this.$config.base_url + "v1/weight",
          data: payload,
          method: "POST"
        });
        this.weightValue = ''
        this.bfValue = ''

      } catch (error) {
        console.error(error);
      }

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
  background-color: #f1faee;
  width: 350px;
  height: 200px;
  border: none;
  border-radius: 25px;
  padding: 10px;
}
.card input {
  text-align: center;
  padding: 0;
  /* margin-top: 10px; */
  color: #1d3557;
  border: none;
  border-bottom: 1px solid #1d3557;
  background: transparent;
  font-family: "Open Sans Condensed", sans-serif;
  font-size: 14px;
  font-weight: bold;
}
.first_input {
  max-width: 200px;
}
.second_input {
  max-width: 150px;
}
.picker {
  margin: 5px;
  max-width: 100px;
  max-height: 25px;
  text-align: center;
}
.but {
  margin-bottom: 7px;
  margin-top: 7px;
  width: 100px;
  height: 50px;
}
</style>