<template>
  <div class="box">
    <div class="login-box">
      <h1>Sign Up</h1>
      <div class="textbox">
        <i class="fas fa-user"></i>
        <input type="text" placeholder="Email" v-model="email" />
      </div>

      <div class="textbox">
        <i class="fas fa-lock"></i>
        <input type="password" placeholder="Password" v-model="password" />
      </div>

       <div class="textbox">
        <i class="fas fa-lock"></i>
        <input type="password" placeholder="re type password" v-model="repassword" />
      </div>

      <input type="button" class="btn" value="Sign in" @click.once="login()"/>
    </div>
  </div>
</template>

<script>
export default {
  name: "Register",
  data() {
    return {
      email: "",
      password: "",
      repassword: "",

    };
  },
  methods: {
    login: async () => {
      let email = this.email;
      let pass = this.password;
      try {
        await this.$store.dispatch("login", { email, pass });
        this.$router.push("/");
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
}
.login-box {
  margin: 0;
  padding: 0;
  font-family: sans-serif;
  /* background: url(https://hdqwalls.com/wallpapers/green-blue-violet-gradient-8k-xv.jpg) no-repeat;
  background-size: cover; */
  width: 280px;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: #457b9d;
}
.login-box h1 {
  float: left;
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