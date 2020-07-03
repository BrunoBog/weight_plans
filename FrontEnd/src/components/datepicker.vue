<template>
  <div class="picker">
    <datepicker
      placeholder="Select Date"
      language="ptBR"
      class="dp"
      input-class="inputs"
      :v-model="selectDate"
      @selected="changeNewDate"
      calendar-class="inputs"
    />
  </div>
</template>

<script>
import Datepicker from "@hokify/vuejs-datepicker/dist/vuejs-datepicker.esm.js";
import "moment/min/locales.min";
import "@hokify/vuejs-datepicker/dist/vuejs-datepicker.css";
import "dayjs";
import {mapState, mapActions} from 'vuex'

export default {
  name: "DatePicker",
  components: {
    Datepicker
  },
  computed:{
    ...mapState({
        selectDate: state => state.selectDate
    })
  },
  methods: {
    ...mapActions(['changeNewDate']),
    Escolheu: () => {
      console.log(this.selectDate)
      // this.changeNewDate(this.selectDate)
    }
  }
};
</script>

<style>
.inputs {
  background-color: #f1faee;
  border: none;
  border-bottom: 1px solid #1d3557;
  font-family: "Open Sans Condensed", sans-serif;
  font-size: 14px;
  color: #1d3557;
  text-align: center;
  padding: 0;
}

.inputs ::placeholder {
  color: #1d3557;
}

input,
select {
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