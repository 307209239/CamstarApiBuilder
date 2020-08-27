// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventFailureActions
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UpdateEventFailureActions : UpdateEventDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventFailureActions_EventFailureDetails")]
    protected EventFailureDetail[] _EventFailureDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventFailureActions_EventFailureActionDetails")]
    protected EventFailureActionDetail[] _EventFailureActionDetails;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventFailureActions && this.CompareArrays((Array) this._EventFailureDetails, (Array) ((UpdateEventFailureActions) obj)._EventFailureDetails) && this.CompareArrays((Array) this._EventFailureActionDetails, (Array) ((UpdateEventFailureActions) obj)._EventFailureActionDetails) && base.Equals(obj);
    }

    public EventFailureDetail[] EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail[]) this.PropertyGet(nameof (EventFailureDetails));
      }
    }

    public EventFailureActionDetail[] EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail[]) this.PropertyGet(nameof (EventFailureActionDetails));
      }
    }
  }
}
