// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserCodeWithWMMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserCodeWithWMMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_LoadESigDetails_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Parameters parameters,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserCodeWithWMMaintMethod[] methods,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserCodeWithWMMaint userCodeWithWMMaint,
      UserCodeWithWMMaint_Request request,
      out UserCodeWithWMMaint_Result result);
  }
}
