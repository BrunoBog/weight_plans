<template>
  <div class="picker">
      <datepicker placeholder="Select Date" language="ptBR"  class="dp" input-class="inputs"/>
  </div>
</template>

<script>
// import VueTailwindPicker from "vue-tailwind-picker";
import Datepicker from "@hokify/vuejs-datepicker/dist/vuejs-datepicker.esm.js";
// import moment from "moment";
import "moment/min/locales.min"; // include all moment js locales for demo project, see https://momentjs.com/docs/#/i18n/
import "@hokify/vuejs-datepicker/dist/vuejs-datepicker.css"; // include CSS


import 'dayjs'
export default {
  name: "DatePicker",
  components: {
    // VueTailwindPicker
    Datepicker
  },
  data() {
    return {

    }
  }
};
</script>

<style scoped>
.dp{
  background-color: #ddd;
}

.inputs{
  padding: 10px;
  min-width: 20px;
  height: 30px;
}

input,
select {
  padding: 0.75em 0.5em;
  font-size: 16px%;
  border: 1px solid #ccc;
  width: 100%;
}

select {
  height: 2.5em;
}

.example {
  background: #f2f2f2;
  /* border: 1px solid #ddd; */
  /* padding: 0em 1em 1em; */
  margin-bottom: 2em;
}

code,
pre {
  margin: 1em 0;
  padding: 1em;
  border: 1px solid #bbb;
  display: block;
  background: #ddd;
  border-radius: 3px;
}

.settings {
  margin: 2em 0;
  border-top: 1px solid #bbb;
  background: #eee;
}

h5 {
  font-size: 100%;
  padding: 0;
}

.form-group {
  margin-bottom: 1em;
}

.form-group label {
  font-size: 80%;
  display: block;
} 
</style>