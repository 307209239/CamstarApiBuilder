// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailMessageChanges
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
  public class EMailMessageChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Subject")]
    protected Primitive<string> _Subject;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Sender")]
    protected Primitive<string> _Sender;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Message")]
    protected Primitive<string> _Message;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_MessageFormat")]
    protected Enumeration<MessageFormatEnum, int> _MessageFormat;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_SendEMailOnTxnFailure")]
    protected Primitive<bool> _SendEMailOnTxnFailure;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is EMailMessageChanges && object.Equals((object) this._Subject, (object) ((EMailMessageChanges) obj)._Subject) && (object.Equals((object) this._Sender, (object) ((EMailMessageChanges) obj)._Sender) && object.Equals((object) this._Message, (object) ((EMailMessageChanges) obj)._Message)) && (object.Equals((object) this._ObjectToChange, (object) ((EMailMessageChanges) obj)._ObjectToChange) && object.Equals((object) this._MessageFormat, (object) ((EMailMessageChanges) obj)._MessageFormat) && (object.Equals((object) this._SendEMailOnTxnFailure, (object) ((EMailMessageChanges) obj)._SendEMailOnTxnFailure) && object.Equals((object) this._Name, (object) ((EMailMessageChanges) obj)._Name))) && base.Equals(obj);
    }

    public Primitive<string> Subject
    {
      [param: In] set
      {
        this.PropertySet(nameof (Subject), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Subject));
      }
    }

    public Primitive<string> Sender
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sender), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Sender));
      }
    }

    public Primitive<string> Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Message));
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

    public Enumeration<MessageFormatEnum, int> MessageFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageFormat), (object) value);
      }
      get
      {
        return (Enumeration<MessageFormatEnum, int>) this.PropertyGet(nameof (MessageFormat));
      }
    }

    public Primitive<bool> SendEMailOnTxnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (SendEMailOnTxnFailure), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SendEMailOnTxnFailure));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
