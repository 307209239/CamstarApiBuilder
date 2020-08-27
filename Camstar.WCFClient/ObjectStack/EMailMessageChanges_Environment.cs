// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailMessageChanges_Environment
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
  public class EMailMessageChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Comments", "", false, true, false, "String", 1051163, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Environment_Subject")]
    protected Environment _Subject;
    [Metadata("E-mail Address", "", false, true, false, "String", 1049907, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Environment_Sender")]
    protected Environment _Sender;
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, false, "String", 1051161, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Environment_Message")]
    protected Environment _Message;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Environment_ObjectToChange")]
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("MessageFormat", "MessageFormatEnum", false, false, false, "Integer", 1051198, false, false, true, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Environment_MessageFormat")]
    protected Environment _MessageFormat;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051162, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Environment_SendEMailOnTxnFailure")]
    protected Environment _SendEMailOnTxnFailure;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051695, false, false, false, null)]
    protected new Environment _Name;

    public Environment Subject
    {
      [param: In] set
      {
        this.PropertySet(nameof (Subject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Subject));
      }
    }

    public Environment Sender
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sender), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sender));
      }
    }

    public Environment Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Message));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment MessageFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageFormat), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MessageFormat));
      }
    }

    public Environment SendEMailOnTxnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (SendEMailOnTxnFailure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SendEMailOnTxnFailure));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
