

export interface Employee{
    employeeId: number;
    name: string;
    hireDate: Date;
    salary: number;
    roleId: number;
    classId: number;
    Class : Class;
}

export interface Class{
    classId: number;
    className: string;
    activity: string;
    intensity: string;
    startTime: Date;
    endTime: Date;
    weekDay: string;

}
