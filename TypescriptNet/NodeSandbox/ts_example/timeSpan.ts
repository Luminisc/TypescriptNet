export interface TimeSpan { 
    ticks?: number;
    days?: number;
    hours?: number;
    milliseconds?: number;
    minutes?: number;
    seconds?: number;
    readonly totalDays?: number;
    readonly totalHours?: number;
    readonly totalMilliseconds?: number;
    readonly totalMinutes?: number;
    readonly totalSeconds?: number;
}