﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SMTPTransportMaint
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
  public class SMTPTransportMaint : DataTransportMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportMaint_ObjectChanges")]
    protected SMTPTransportChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is SMTPTransportMaint && object.Equals((object) this._ObjectChanges, (object) ((SMTPTransportMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((SMTPTransportMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((SMTPTransportMaint) obj)._ObjectListInquiry)) && base.Equals(obj);
    }

    public SMTPTransportChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SMTPTransportChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
