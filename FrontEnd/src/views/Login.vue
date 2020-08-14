<template>
  <div class="box">
    <div class="login-box">
      <h1>Login</h1>
      <div class="textbox">
        <i class="fas fa-user"></i>
        <input type="text" placeholder="Email" v-model="email" />
      </div>

      <div class="textbox">
        <i class="fas fa-lock"></i>
        <input type="password" placeholder="Password" v-model="password" />
      </div>
      <input type="button" class="btn" value="Sign in" @click.once="login" />
    </div>
  </div>
</template>

<script>
export default {
  name: "login",
  data() {
    return {
      email: "",
      password: ""
    };
  },
  methods: {
    async login() {
      let Email = this.email;
      let Password = this.password;
      try {
        let resp = await this.$http({
          url: this.$config.base_url + "v1/User/login",
          data: { Email, Password },
          method: "POST"
        });
        const token = resp.data.token;
        const user = resp.data.user;
        localStorage.setItem("token", token);
        localStorage.setItem("user", user);
        this.$http.defaults.headers.common["Authorization"] = token;
        this.$router.push("Home");
      } catch (e) {
        console.log(e);
      }
    }
  }
};
</script>

<style>
.box {
  display: flex;
  align-items: center;
  justify-content: center;
  height: 100vh;
  background: url(https://mir-s3-cdn-cf.behance.net/project_modules/1400_opt_1/4d63ac64120315.5ac773360206a.png)
    no-repeat;
  background-size: cover;

}
.login-box {
  
  margin: 0;
  padding: 0;
  font-family: sans-serif;
  width: 280px;
  color: #457b9d;
}
.login-box h1 {
  /* float: left; */
  font-size: 40px;
  border-bottom: 6px solid #e63946;
  margin-bottom: 50px;
  padding: 13px 0;
}
.textbox {
  width: 100%;
  overflow: hidden;
  font-size: 20px;
  padding: 8px 0;
  margin: 8px 0;
  border-bottom: 1px solid #e63946;
}
.textbox i {
  width: 26px;
  float: left;
  text-align: center;
}
.textbox input {
  border: none;
  outline: none;
  background: none;
  color: #457b9d;
  font-size: 18px;
  width: 80%;
  float: left;
  margin: 0 10px;
}
.btn {
  width: 100%;
  background: none;
  border: 2px solid #e63946;
  color: #457b9d;
  padding: 5px;
  font-size: 18px;
  cursor: pointer;
  margin: 12px 0;
}
</style>