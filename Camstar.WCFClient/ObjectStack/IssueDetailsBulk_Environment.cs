// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetailsBulk_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CompDistributeDetailsBulk_Environment))]
  [Serializable]
  public class IssueDetailsBulk_Environment : IssueDetails_Environment
  {
    [Metadata("Used for Bulk Container Issues\r\nDo not decrement the qty for RecipeIssues where the UOM's don't match", "ActualsBulk", false, false, false, "ActualsBulk", 1049642, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsBulk_Environment_Actuals")]
    protected ActualsBulk_Environment _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsBulk_Environment_IssueControl")]
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049463, false, false, false, "2")]
    protected new Environment _IssueControl;

    public ActualsBulk_Environment Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (ActualsBulk_Environment) this.PropertyGet(nameof (Actuals));
      }
    }

    public new Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }
  }
}
