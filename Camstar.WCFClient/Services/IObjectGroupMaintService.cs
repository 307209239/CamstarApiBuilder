// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IObjectGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IObjectGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_LoadESigDetails_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Parameters parameters,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ObjectGroupMaintMethod[] methods,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ObjectGroupMaint objectGroupMaint,
      ObjectGroupMaint_Request request,
      out ObjectGroupMaint_Result result);
  }
}
