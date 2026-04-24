namespace HellsingLogistics.Domain;
public enum UserRoleType{
    Cancelled = 7
}

public enum ReadinessState
{
    Unknown = 0,
    Ready = 1,
    Partial = 2,
    Blocked = 3
}

public enum ApprovalDecisionType
{
    Approved = 1,
    Denied = 2,
    OnHold = 3,
    ReturnedForChanges = 4
}

public enum InventorySourceType
{
    ManualEntry = 1,
    MiningRefinement = 2,
    AdminAdjustment = 3,
    ReturnedMaterials = 4
}

public enum InventoryTransactionType
{
    Intake = 1,
    Reservation = 2,
    ReservationRelease = 3,
    Consumption = 4,
    Adjustment = 5,
    Return = 6
}

public enum ReservationStatus
{
    Active = 1,
    Consumed = 2,
    Released = 3,
    Cancelled = 4
}

public enum WorkOrderStatus
{
    Open = 1,
    Ready = 2,
    Assigned = 3,
    InProgress = 4,
    Blocked = 5,
    Partial = 6,
    Complete = 7,
    Cancelled = 8
}

public enum QualityBand
{
    Unknown = 0,
    Low = 1,
    Standard = 2,
    Good = 3,
    Premium = 4,
    Exceptional = 5
}
