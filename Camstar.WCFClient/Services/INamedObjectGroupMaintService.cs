// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INamedObjectGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INamedObjectGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_LoadESigDetails_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Parameters parameters,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NamedObjectGroupMaintMethod[] methods,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NamedObjectGroupMaint namedObjectGroupMaint,
      NamedObjectGroupMaint_Request request,
      out NamedObjectGroupMaint_Result result);
  }
}
