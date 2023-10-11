function my_function(message) {
    console.log(message)
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount").then(result => {
        console.log("count from js" + result)
    })
}

function dotnetInstanceInvocation(helper) {
    helper.invokeMethodAsync("IncrementCount")
}