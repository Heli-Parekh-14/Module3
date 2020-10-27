There are 4 access modifiers (public, protected, internal, private) which defines the 6 accessibility levels as follows:
  public
  protected
  internal
  protected internal
  private
  private protected
Namespaces doesn’t allow the access modifiers as they have no access restrictions.
The user is allowed to use only one accessibility at a time except the private protected and protected internal.
The default accessibility for the top-level types(that are not nested in other types, can only have public or internal accessibility) is internal.
[For data members in class,default accessibility is private].
If no access modifier is specified for a member declaration, then the default accessibility is used based on the context.
