<template>
  <div class="picker">
      <datepicker placeholder="Select Date" language="ptBR"  class="dp"  input-class="inputs" v-model="vmodelexample" calendar-class="inputs" />
  </div>
</template>

<script>
 import Datepicker from "@hokify/vuejs-datepicker/dist/vuejs-datepicker.esm.js";
import "moment/min/locales.min"; // include all moment js locales for demo project, see https://momentjs.com/docs/#/i18n/
import "@hokify/vuejs-datepicker/dist/vuejs-datepicker.css"; // include CSS


import 'dayjs'
export default {
  name: "DatePicker",
  components: {
    Datepicker
  },
  data() {
    return {
      vModelExample: null,
    }
  }
};
</script>

<style>
.inputs{
  background-color: #F1FAEE;
  border: none;
  border-bottom: 1px solid #1d3557;
  font-family: "Open Sans Condensed", sans-serif;
  font-size: 14px;
  color: #1d3557;
  text-align:center;
}

.inputs ::placeholder {
  color: #1d3557;
}

input, select {
  padding: 0.75em 0.5em;
  font-size: 16px;
  border: 1px solid #ccc;
  width: 100%;
}

select {
  height: 2.5em;
}


h5 {
  font-size: 100%;
  padding: 0;
}

</style>