// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICommentTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICommentTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_LoadESigDetails_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CommentTypeMaintMethod[] methods,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result);
  }
}
