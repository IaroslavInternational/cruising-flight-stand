clc;
clear;
close all;

%% 02.03.2023

List = readtable("log2.xlsx");
List_range = 9520:10189;

Time  = List(List_range, 2);
T5    = List(List_range, 12);
Speed = List(List_range, 22);

Time_arr  = [];
T5_arr    = [];
Speed_arr = [];

Time_arr  = table2array(Time(:, 1));
T5_arr    = table2array(T5(:, 1));
Speed_arr = table2array(Speed(:, 1));

Time_arr = ConvertToTime(Time_arr(:, 1));

xtick_idx = 0:length(Time_arr)/10:length(Time_arr);
xtick_idx(1) = 1;

figure;
subplot(2, 1, 1);
plot_data(T5_arr, 0.1);
title("List 02.03.23 - Tenzo 5");
ylabel("gramms");

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

subplot(2, 1, 2);
plot_data(Speed_arr, 0.1)
title("List 02.03.23 - Speed");
ylabel("km/h");

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

saveas(gcf,'img/02.03.23 Tenzo 5 + Speed.png');

%% 03.03.2023 - Range 1

List = readtable("log3.xlsx");
List_range = 10604:11318;

Time  = List(List_range, 2);
T5    = List(List_range, 12);
S     = List(List_range, 14);
Speed = List(List_range, 22);

Time_arr  = [];
T5_arr    = [];
S_arr     = [];
Speed_arr = [];

Time_arr  = table2array(Time(:, 1));
T5_arr    = table2array(T5(:, 1));
S_arr     = table2array(S(:, 1));
Speed_arr = table2array(Speed(:, 1));

for i = 1:5
    Time_arr(length(Time_arr) + 1)   = Time_arr(length(Time_arr));
    T5_arr(length(T5_arr) + 1)       = T5_arr(length(T5_arr));
    S_arr(length(S_arr) + 1)         = S_arr(length(S_arr));
    Speed_arr(length(Speed_arr) + 1) = Speed_arr(length(Speed_arr));
end

Time_arr = ConvertToTime(Time_arr(:, 1));
S_arr = (S_arr - 28000) .* 10;

xtick_idx = 0:length(Time_arr)/10:length(Time_arr);
xtick_idx(1) = 1;

figure;
subplot(3, 1, 1);
plot_data(T5_arr, 0.1);
title("List 03.03.23 - Tenzo 5 Range 1");
ylabel("gramms");

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

subplot(3, 1, 2);
plot_data(S_arr, 0.1);
title("List 03.03.23 - Tenzo Sum Range 1");
ylabel("gramms");

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

subplot(3, 1, 3);
plot_data(Speed_arr, 0.1);
title("List 03.03.23 - Speed Range 1");
ylabel("km/h");

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

saveas(gcf,'img/Tenzo 5 + Tenzo Sum + Speed Range 1.png');

%% 03.03.2023 - Range 2

List_range = 33653:34372;

Time  = List(List_range, 2);
T5    = List(List_range, 12);
S     = List(List_range, 14);
P     = List(List_range, 20);
Speed = List(List_range, 22);

Time_arr  = [];
T5_arr    = [];
S_arr     = [];
P_arr     = [];
Speed_arr = [];

Time_arr  = table2array(Time(:, 1));
T5_arr    = table2array(T5(:, 1));
S_arr     = table2array(S(:, 1));
P_arr     = table2array(P(:, 1));
Speed_arr = table2array(Speed(:, 1));

Time_arr = ConvertToTime(Time_arr(:, 1));
S_arr = (S_arr - 28000) .* 10;

xtick_idx = 0:length(Time_arr)/10:length(Time_arr);
xtick_idx(1) = 1;

figure;
subplot(3, 1, 1);
plot_data(T5_arr, 0.1);
title("List 03.03.23 - Tenzo 5 Range 2");
ylabel("gramms");

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

subplot(3, 1, 2);
plot_data(P_arr, 0.1);
title("List 03.03.23 - Power Range 2");
ylabel("Wt");

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

subplot(3, 1, 3);
plot_data(Speed_arr, 0.1);
title("List 03.03.23 - Speed Range 2");
ylabel("km/h");

set(gca,'XTick', 0:length(Time_arr)/10:length(Time_arr)); 
set(gca,'XTickLabel',Time_arr(xtick_idx));

saveas(gcf,'img/Tenzo 5 + Power + Speed Range 2.png');

%%

function time = ConvertToTime(val)
    hours = val * 24;
    minutes = mod(hours, floor(hours)) * 60;
    seconds = mod(minutes, floor(minutes)) * 60;

    time = floor(hours) + ":" + floor(minutes) + ":" + seconds;
end

function plot_data(arr, smoothness)
    grid on;
    hold on;
    plot(arr);
    plot(smooth(arr, smoothness));
    hold off;
end
