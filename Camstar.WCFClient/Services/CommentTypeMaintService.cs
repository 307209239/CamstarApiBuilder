// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CommentTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CommentTypeMaintService : UserCodeMaintBase
  {
    public CommentTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICommentTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).Delete(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CommentTypeMaint) null, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus Delete(CommentTypeMaint commentTypeMaint)
    {
      return this.Delete(commentTypeMaint, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus Delete(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.Delete(commentTypeMaint, (CommentTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).Freeze(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CommentTypeMaint) null, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus Freeze(CommentTypeMaint commentTypeMaint)
    {
      return this.Freeze(commentTypeMaint, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.Freeze(commentTypeMaint, (CommentTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CommentTypeMaint) null, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(CommentTypeMaint commentTypeMaint)
    {
      return this.GetWIPMsgs(commentTypeMaint, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.GetWIPMsgs(commentTypeMaint, (CommentTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).Load(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CommentTypeMaint) null, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus Load(CommentTypeMaint commentTypeMaint)
    {
      return this.Load(commentTypeMaint, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus Load(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.Load(commentTypeMaint, (CommentTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_LoadESigDetails_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.LoadESigDetails, (CommentTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CommentTypeMaint) null, (CommentTypeMaint_LoadESigDetails_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(CommentTypeMaint commentTypeMaint)
    {
      return this.LoadESigDetails(commentTypeMaint, (CommentTypeMaint_LoadESigDetails_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.LoadESigDetails(commentTypeMaint, (CommentTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).New(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CommentTypeMaint) null, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus New(CommentTypeMaint commentTypeMaint)
    {
      return this.New(commentTypeMaint, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus New(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.New(commentTypeMaint, (CommentTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).NewCopy(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CommentTypeMaint) null, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus NewCopy(CommentTypeMaint commentTypeMaint)
    {
      return this.NewCopy(commentTypeMaint, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.NewCopy(commentTypeMaint, (CommentTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).SaveAs(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CommentTypeMaint) null, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus SaveAs(CommentTypeMaint commentTypeMaint)
    {
      return this.SaveAs(commentTypeMaint, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.SaveAs(commentTypeMaint, (CommentTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Parameters parameters,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).UnFreeze(this._UserProfile, commentTypeMaint, parameters, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(commentTypeMaint, CommentTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) commentTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CommentTypeMaint) null, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(CommentTypeMaint commentTypeMaint)
    {
      return this.UnFreeze(commentTypeMaint, (CommentTypeMaint_Parameters) null, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CommentTypeMaint commentTypeMaint,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.UnFreeze(commentTypeMaint, (CommentTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_LoadESigDetails_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject commentTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CommentTypeMaint) commentTypeMaint, (CommentTypeMaint_Parameters) parameters, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      try
      {
        CommentTypeMaintMethod[] methods = new CommentTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICommentTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CommentTypeMaint cdo,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      try
      {
        return ((ICommentTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CommentTypeMaint) cdo, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.GetEnvironment((CommentTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CommentTypeMaint cdo,
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      result = (CommentTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICommentTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CommentTypeMaintMethod(cdo, CommentTypeMaintMethods.ExecuteTransaction, (CommentTypeMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CommentTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CommentTypeMaint) cdo, (CommentTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CommentTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CommentTypeMaint_Request) null, out CommentTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CommentTypeMaint_Request request,
      out CommentTypeMaint_Result result)
    {
      return this.ExecuteTransaction((CommentTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CommentTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CommentTypeMaintMethod(cdo, CommentTypeMaintMethods.AddDataTransaction, (CommentTypeMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((CommentTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
