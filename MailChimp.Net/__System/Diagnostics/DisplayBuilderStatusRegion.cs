using System.Runtime.CompilerServices;

namespace System.Diagnostics {
    internal class DisplayBuilderStatusRegion : DisplayBuilderRegion {
        public DisplayBuilderStatusRegion(string Format, DisplayBuilder Parent) : base(Format, Parent) {
        
        }

        public new DisplayBuilderStatusRegion If(bool Condition) {
            var ret = Condition
                ? this
                : new DisplayBuilderStatusRegion(Format, Parent)
                ;

            return ret;
        }

        public DisplayBuilder Is(bool Value, [CallerArgumentExpression("Value")] string? Name = default) {
            return this.If(Value).Add(Name);
        }

        public DisplayBuilder IsOverdue(bool Value = true) {
            return this.If(Value, Then => Then.Add("Overdue"));
        }

        public DisplayBuilder IsNotOverdue(bool Value = true) {
            return IsOverdue(!Value);
        }


        public DisplayBuilder IsConflict(bool Value = true) {
            return this.If(Value, Then => Then.Add("Conflict"));
        }

        public DisplayBuilder IsNotConflict(bool Value = true) {
            return IsConflict(!Value);
        }

        public DisplayBuilder IsEnabled(bool Value = true) {
            return IsNotEnabled(!Value);
        }

        public DisplayBuilder IsNotEnabled(bool Value = true) {
            return this.If(Value, Then => Then.Add("Disabled"));
        }

        public DisplayBuilder IsVisible(bool Value = true) {
            return IsNotVisible(!Value);
        }

        public DisplayBuilder IsNotVisible(bool Value = true) {
            return this.If(Value, Then => Then.Add("Hidden"));
        }

        public DisplayBuilder IsNotLocked(bool Value = true) {
            return IsLocked(!Value);
        }

        public DisplayBuilder IsApproved(bool Value = true) {
            return this.If(Value, Then => Then.Add("Approved"));
        }

        public DisplayBuilder IsNotApproved(bool Value = true) {
            return IsApproved(!Value);
        }

        public DisplayBuilder IsCurrent(bool Value = true) {
            return this.If(Value, Then => Then.Add("Current"));
        }

        public DisplayBuilder IsNotCurrent(bool Value = true) {
            return IsCurrent(!Value);
        }

        public DisplayBuilder IsFavorite(bool Value = true) {
            return this.If(Value, Then => Then.Add("Favorite"));
        }

        public DisplayBuilder IsNotFavorite(bool Value = true) {
            return IsFavorite(!Value);
        }

        public DisplayBuilder IsSigned(bool Value = true) {
            return this.If(Value, Then => Then.Add("Signed"));
        }

        public DisplayBuilder IsNotSigned(bool Value = true) {
            return this.If(Value, Then => Then.Add("UNSIGNED"));
        }


        public DisplayBuilder IsLocked(bool Value = true) {
            return this.If(Value, Then => Then.Add("Locked"));
        }

        public DisplayBuilder IsNotDeleted(bool Value = true) {
            return IsDeleted(!Value);
        }

        public DisplayBuilder IsDeleted(bool Value = true) {
            return this.If(Value, Then => Then.Add("Deleted"));
        }

        public DisplayBuilder IsNotRoot(bool Value = true) {
            return IsRoot(!Value);
        }

        public DisplayBuilder IsRoot(bool Value = true) {
            return this.If(Value, Then => Then.Add("Root"));
        }

        public DisplayBuilder IsNotPrimary(bool Value = true) {
            return IsPrimary(!Value);
        }

        public DisplayBuilder IsPrimary(bool Value = true) {
            return this.If(Value, Then => Then.Add("Primary"));
        }

        public DisplayBuilder IsNotPresent(bool Value = true) {
            return IsPresent(!Value);
        }

        public DisplayBuilder IsPresent(bool Value = true) {
            return this.If(Value, Then => Then.Add("Present"), Else => Else.Add("Not Present"));
        }

        public DisplayBuilder IsNotPrivate(bool Value = true) {
            return IsPrivate(!Value);
        }

        public DisplayBuilder IsPrivate(bool Value = true) {
            return this.If(Value, Then => Then.Add("Private"));
        }

        public DisplayBuilder IsNotArchived(bool Value = true) {
            return IsArchived(!Value);
        }

        public DisplayBuilder IsArchived(bool Value = true) {
            return this.If(Value, Then => Then.Add("Archived"));
        }

        public DisplayBuilder IsNotRequired(bool Value = true) {
            return IsRequired(!Value);
        }

        public DisplayBuilder IsRequired(bool Value = true) {
            return this.If(Value, Then => Then.Add("Required"));
        }

        public DisplayBuilder IsRedacted(bool Value = true) {
            return this.If(Value, Then => Then.Add("Redacted"));
        }

        public DisplayBuilder IsNotRedacted(bool Value = true) {
            return IsRedacted(!Value);
        }

        public DisplayBuilder IsOwner(bool Value = true) {
            return this.If(Value, Then => Then.Add("Owner"));
        }

        public DisplayBuilder IsNotOwner(bool Value = true) {
            return IsOwner(!Value);
        }

        public DisplayBuilder IsDefault(bool Value = true) {
            return this.If(Value, Then => Then.Add("Default"));
        }

        public DisplayBuilder IsNotDefault(bool Value = true) {
            return IsDefault(!Value);
        }

        public DisplayBuilder IsSuccessOrError(bool Value = true) {
            this.IsSuccess(Value);
            this.IsError(!Value);
            return Parent;
        }

        public DisplayBuilder IsErrorOrSuccess(bool Value = true) {
            this.IsSuccess(!Value);
            this.IsError(Value);
            return Parent;
        }


        public DisplayBuilder IsSuccess(bool Value = true) {
            return this.If(Value, Then => Then.Add("Success"));
        }

        public DisplayBuilder IsNotSuccess(bool Value = true) {
            return IsSuccess(!Value);
        }

        public DisplayBuilder IsError(bool Value = true) {
            return this.If(Value, Then => Then.Add("Error"));
        }

        public DisplayBuilder IsNotError(bool Value = true) {
            return IsError(!Value);
        }


    }

}
