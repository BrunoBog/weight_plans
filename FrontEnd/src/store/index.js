import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    status: '',
    token: localStorage.getItem('token') ?? '',
    user: {},
    dates: [],
    weights: [],
    newDate: Date,
    selectDate: Date
  },
  mutations: {
    change_date: (state, value) => state.selectDate = value,
    printDate: (state) => console.log(state.selectDate),
    auth_request(state) {
      state.status = 'loading'
    },
    auth_success(state, token, user) {
      state.status = 'success'
      state.token = token
      state.user = user
    },
    auth_error(state) {
      state.status = 'error'
    },
    logout(state) {
      state.status = ''
      state.token = ''
    },
    async get_weight_values(state) {
      let resp = await this.$http({
        url: this.$config.base_url + "v1/weight?userID=1",
        method: "GET",
      })

      state.weights = resp.data.map((i) => i.weightValue)
      state.dates = resp.data.map((i) => i.day)
    },
  },
  getters: {
    selectDate: (state) => state.selectDate,
    token: (state) => state.token,
  },
  actions: {
    changeNewDate: ({ commit }, value) => {
      commit('change_date', value)
    },
    printDate: ({ commit }) => commit('printDate')
  },
  modules: {
  }
})
