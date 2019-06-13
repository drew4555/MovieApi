function getAllMovies(){
  document.getElementById("myTable")
 $.get("https://localhost:44312/api/movies", function(data){
   $("#myTable").empty();
  $.each(data, function(key, value){
    $("#myTable").append(`<tr><td>${value.Title} </td> <td> ${value.Genre} </td> <td> ${value.DirectorName} </td></tr>`)
  });
});
};

function addNewMovie( e ){
  var newMovieTitle = $('#title').val()
  var newMovieGenre = $("#genre").val()
  var newMovieDirectorName = $("#directorName").val()
  $.post("https://localhost:44312/api/movies", {Title: newMovieTitle, Genre: newMovieGenre, DirectorName: newMovieDirectorName})
}

function searchByTitle(){
var searchForMovie = $("#mySearch")
$("#myTable").empty()
$.get("https://localhost:44312/api/movies"), function(data){
  $.each(data, function(key, value){
    $("#myTable").append(`<tr><td> ${value.Title}</td><td> ${value.Genre} </td><td> ${value.DirectorName} </td></tr>`).where(searchForMovie == value.Title)
  })
}
}
function searchByGenre(){

}
function searchByDirector(){

}