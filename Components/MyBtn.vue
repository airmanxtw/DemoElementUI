<template>
    <el-button @click="score++">{{score}}</el-button>
</template>
<script>
    module.exports = {
        data: function () {
            return {
                score: 60
            }
        }
    }
</script>
