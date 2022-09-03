export type TaskStatus = 'Created' | 'Queued' | 'InProgress' | 'Completed' | 'Failed';

export const TaskStatus = {
    Created: 'Created' as TaskStatus,
    Queued: 'Queued' as TaskStatus,
    InProgress: 'InProgress' as TaskStatus,
    Completed: 'Completed' as TaskStatus,
    Failed: 'Failed' as TaskStatus
};