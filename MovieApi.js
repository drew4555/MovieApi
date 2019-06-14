function getAllMovies(){
 
  document.getElementById("myTable")
 $.get("https://localhost:44312/api/movies", function(data){
   $("#myTable").empty();
   $.each(data, function(key, value){
    var searchForMovie = $("#mySearch").val()
    if (searchForMovie == "") {
      $("#myTable").append(`<tr><td>${value.Title} </td> <td> ${value.Genre} </td> <td> ${value.DirectorName} </td></tr>`)
  }
    if (value.Title === searchForMovie || value.DirectorName === searchForMovie || value.Genre === searchForMovie)
    {
     
       $("#myTable").append(`<tr><td>${value.Title} </td> <td> ${value.Genre} </td> <td> ${value.DirectorName} </td></tr>`)
    }
    $.each(data, function(key, value){
   
  });
}
 )})}

function addNewMovie( e ){
  var newMovieTitle = $('#title').val()
  var newMovieGenre = $("#genre").val()
  var newMovieDirectorName = $("#directorName").val()
  $.post("https://localhost:44312/api/movies", {Title: newMovieTitle, Genre: newMovieGenre, DirectorName: newMovieDirectorName})
}

function searchForMovie(){
getAllMovies();
}
