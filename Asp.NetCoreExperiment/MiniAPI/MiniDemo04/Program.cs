using MiniDemo04.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddDbContext<ExamContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ExamDatabase")));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/exampaper/{id}", async (ExamContext exam, int id) =>
 {
     return Results.Json(await exam.ExamPapers
     .Include(paper => paper.Questions)
     .ThenInclude(question => question.Answers)
     .Include(paper => paper.Questions)
     .ThenInclude(question => question.QuestionType)
     .Select(paper => new { paper.Id, paper.Title, paper.CreateTime, Scores = paper.Questions.Sum(s => s.Score), Count = paper.Questions.Count, Questions = paper.Questions.Select(question => new { Question = $"{question.Id}、{question.Question1}({question.Score}分  {question.QuestionType.TypeName})", Answers = question.Answers.Select(answer => new { answer.Sequre, Answer = answer.Answer1 }) }) })
     .FirstOrDefaultAsync(s => s.Id == id), new System.Text.Json.JsonSerializerOptions { ReferenceHandler = ReferenceHandler.IgnoreCycles });
 });

app.Run();
