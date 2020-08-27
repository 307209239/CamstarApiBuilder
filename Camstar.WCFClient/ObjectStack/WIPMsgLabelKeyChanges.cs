// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgLabelKeyChanges
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
  public class WIPMsgLabelKeyChanges : WIPMsgKeyChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_Label")]
    protected Primitive<string> _Label;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_WIPMsgDetails")]
    protected new WIPMsgDetailChanges[] _WIPMsgDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgLabelKeyChanges && object.Equals((object) this._Label, (object) ((WIPMsgLabelKeyChanges) obj)._Label) && (this.CompareArrays((Array) this._WIPMsgDetails, (Array) ((WIPMsgLabelKeyChanges) obj)._WIPMsgDetails) && object.Equals((object) this._ObjectToChange, (object) ((WIPMsgLabelKeyChanges) obj)._ObjectToChange)) && base.Equals(obj);
    }

    public Primitive<string> Label
    {
      [param: In] set
      {
        this.PropertySet(nameof (Label), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Label));
      }
    }

    public new WIPMsgDetailChanges[] WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges[]) this.PropertyGet(nameof (WIPMsgDetails));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
