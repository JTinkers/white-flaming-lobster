<template>
    <div id='sample' v-text='text'/>
</template>

<script lang='ts' setup>
    const text = 'Sample Text';
</script>

<style lang='scss' scoped>
    #sample
    {
        display: flex;
        background: red;
        color: black;
    }
</style>