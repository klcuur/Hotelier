using Hotelier.BusinessLayer.Abstract;
using Hotelier.BusinessLayer.Concrete;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.EntityFramework;
using Hotelier.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DBConStr"));
});
builder.Services.AddScoped<IServiceDal,EfServiceDal>();
builder.Services.AddScoped<IServiceService,ServiceManager>();

builder.Services.AddScoped<IStaffService,StaffManager>();
builder.Services.AddScoped<IStaffDal,EfStaffDal>();

builder.Services.AddScoped<IRoomService, RoomManager>();
builder.Services.AddScoped<IRoomDal, EfRoomDal>();

builder.Services.AddScoped<ISubscribeService, SubscribeManager>();
builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
