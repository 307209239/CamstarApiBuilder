// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveTxn_AssignCellContainerClearance_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MoveTxn_AssignCellContainerClearance_Parameters : MoveTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkCell")]
    protected string _WorkCell;

    public string WorkCell
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCell), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (WorkCell));
      }
    }
  }
}
