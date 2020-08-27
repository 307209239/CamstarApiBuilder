// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBOMMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBOMMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_LoadESigDetails_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BOMMaintMethod[] methods,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result);
  }
}
