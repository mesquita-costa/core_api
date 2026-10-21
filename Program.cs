using core_api.Infra;
using core_api.Infra.Repository;
using core_api.Model.Interface;
using core_api.service.bi;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAuditoriaRepository, AuditoriaRepository>();
builder.Services.AddScoped<IBankRepository, BankRepository>();
builder.Services.AddScoped<AccountsPayableService>();
builder.Services.AddScoped<AccountsReceivableService>();
builder.Services.AddScoped<FinancialCashFlowService>();
builder.Services.AddScoped<FinancialOverviewService>();
builder.Services.AddScoped<PaymentMethodsService>();
builder.Services.AddScoped<RevenueCategoryService>();
builder.Services.AddScoped<ExpenseCategoryService>();
builder.Services.AddScoped<BiFilterOptionsService>();

builder.Services.AddDbContext<Context>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFlutter",
        policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});




#region repositorios

builder.Services.AddScoped<IBankRepository, BankRepository>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowFlutter");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

