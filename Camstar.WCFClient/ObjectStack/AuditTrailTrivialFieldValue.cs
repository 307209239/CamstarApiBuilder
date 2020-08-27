// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailTrivialFieldValue
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
  public class AuditTrailTrivialFieldValue : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialFieldValue_NewValue")]
    protected Primitive<string> _NewValue;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialFieldValue_OldValue")]
    protected Primitive<string> _OldValue;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialFieldValue_Action")]
    protected Primitive<string> _Action;

    public override bool Equals(object obj)
    {
      return obj is AuditTrailTrivialFieldValue && object.Equals((object) this._NewValue, (object) ((AuditTrailTrivialFieldValue) obj)._NewValue) && (object.Equals((object) this._OldValue, (object) ((AuditTrailTrivialFieldValue) obj)._OldValue) && object.Equals((object) this._Action, (object) ((AuditTrailTrivialFieldValue) obj)._Action)) && base.Equals(obj);
    }

    public Primitive<string> NewValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NewValue));
      }
    }

    public Primitive<string> OldValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OldValue));
      }
    }

    public Primitive<string> Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Action));
      }
    }
  }
}
