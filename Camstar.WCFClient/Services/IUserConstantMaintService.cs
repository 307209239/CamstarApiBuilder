// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserConstantMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserConstantMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_LoadESigDetails_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserConstantMaintMethod[] methods,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result);
  }
}
