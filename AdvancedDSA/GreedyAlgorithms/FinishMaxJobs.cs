/*
There are N jobs to be done, but you can do only one job at a time.

Given an array A denoting the start time of the jobs and an array B denoting the finish time of the jobs.

Your aim is to select jobs in such a way so that you can finish the maximum number of jobs.

Return the maximum number of jobs you can finish.

Problem Constraints
1 <= N <= 105

1 <= A[i] < B[i] <= 109

Input Format
The first argument is an integer array A of size N, denoting the start time of the jobs.
The second argument is an integer array B of size N, denoting the finish time of the jobs.

Output Format
Return an integer denoting the maximum number of jobs you can finish.

Example Input
Input 1:

 A = [1, 5, 7, 1]
 B = [7, 8, 8, 8]
Input 2:

 A = [3, 2, 6]
 B = [9, 8, 9]

Example Output
Output 1:

 2
Output 2:

 1

Example Explanation
Explanation 1:

 We can finish the job in the period of time: (1, 7) and (7, 8).
Explanation 2:

 Since all three jobs collide with each other. We can do only 1 job.
 */

public static class FinishMaxJobs
{
    class JobSchedule {
        public int startTime { get; set; }
        public int endTime { get; set; }        
    }

    class ScheduleComparer : IComparer<JobSchedule>
    {
        public int Compare(JobSchedule x, JobSchedule y) {

            if (x.endTime < y.endTime) {
                return -1;
            }
            else if (x.endTime == y.endTime) {

                if (x.startTime > y.startTime)
                {
                    return 1;
                }
                else if (x.startTime == y.startTime) { 
                    return 0;
                }
                else {
                    return -1;
                }
            }
            else {
                return 1;
            }
        }
    }

    public static int solve(List<int> A, List<int> B)
    {
        int res = 0;
        List<JobSchedule> schedules = new List<JobSchedule>();

        for (int i = 0; i < A.Count; i++) {

            JobSchedule schedule = new JobSchedule();

            schedule.startTime = A[i];
            schedule.endTime = B[i];

            schedules.Add(schedule);
        }

        schedules.Sort(new ScheduleComparer());

        int currEndTime = -1;
        for (int i = 0; i < schedules.Count; i++) {

            if (schedules[i].startTime >= currEndTime) {
                res++;
                currEndTime = schedules[i].endTime;
            }
        }

        return res;
    }
}