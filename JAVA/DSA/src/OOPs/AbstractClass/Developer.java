package OOPs.AbstractClass;

public class Developer extends Employee {
    @Override
    void work() {
        System.out.println("Developer working");
    }

    public void markAttendance(){
        System.out.println("Developer attedance");
    }
}
