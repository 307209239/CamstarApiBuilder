// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserCodeMaintService : NamedDataObjectMaintBase
  {
    public UserCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).Delete(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserCodeMaint) null, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus Delete(UserCodeMaint userCodeMaint)
    {
      return this.Delete(userCodeMaint, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus Delete(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.Delete(userCodeMaint, (UserCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).Freeze(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserCodeMaint) null, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus Freeze(UserCodeMaint userCodeMaint)
    {
      return this.Freeze(userCodeMaint, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.Freeze(userCodeMaint, (UserCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserCodeMaint) null, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UserCodeMaint userCodeMaint)
    {
      return this.GetWIPMsgs(userCodeMaint, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.GetWIPMsgs(userCodeMaint, (UserCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).Load(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserCodeMaint) null, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus Load(UserCodeMaint userCodeMaint)
    {
      return this.Load(userCodeMaint, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus Load(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.Load(userCodeMaint, (UserCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_LoadESigDetails_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.LoadESigDetails, (UserCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserCodeMaint) null, (UserCodeMaint_LoadESigDetails_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UserCodeMaint userCodeMaint)
    {
      return this.LoadESigDetails(userCodeMaint, (UserCodeMaint_LoadESigDetails_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.LoadESigDetails(userCodeMaint, (UserCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).New(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserCodeMaint) null, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus New(UserCodeMaint userCodeMaint)
    {
      return this.New(userCodeMaint, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus New(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.New(userCodeMaint, (UserCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).NewCopy(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserCodeMaint) null, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus NewCopy(UserCodeMaint userCodeMaint)
    {
      return this.NewCopy(userCodeMaint, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.NewCopy(userCodeMaint, (UserCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).SaveAs(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserCodeMaint) null, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus SaveAs(UserCodeMaint userCodeMaint)
    {
      return this.SaveAs(userCodeMaint, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.SaveAs(userCodeMaint, (UserCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).UnFreeze(this._UserProfile, userCodeMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(userCodeMaint, UserCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserCodeMaint) null, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(UserCodeMaint userCodeMaint)
    {
      return this.UnFreeze(userCodeMaint, (UserCodeMaint_Parameters) null, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.UnFreeze(userCodeMaint, (UserCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserCodeMaint) userCodeMaint, (UserCodeMaint_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserCodeMaint) userCodeMaint, (UserCodeMaint_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserCodeMaint) userCodeMaint, (UserCodeMaint_LoadESigDetails_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((UserCodeMaint) userCodeMaint, (UserCodeMaint_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserCodeMaint) userCodeMaint, (UserCodeMaint_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserCodeMaint) userCodeMaint, (UserCodeMaint_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserCodeMaint) userCodeMaint, (UserCodeMaint_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserCodeMaint) userCodeMaint, (UserCodeMaint_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserCodeMaint) userCodeMaint, (UserCodeMaint_Parameters) parameters, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      try
      {
        UserCodeMaintMethod[] methods = new UserCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserCodeMaint cdo,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      try
      {
        return ((IUserCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UserCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserCodeMaint) cdo, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.GetEnvironment((UserCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserCodeMaint cdo,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      result = (UserCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserCodeMaintMethod(cdo, UserCodeMaintMethods.ExecuteTransaction, (UserCodeMaint_Parameters) null));
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
        UserCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserCodeMaint) cdo, (UserCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserCodeMaint_Request) null, out UserCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result)
    {
      return this.ExecuteTransaction((UserCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserCodeMaintMethod(cdo, UserCodeMaintMethods.AddDataTransaction, (UserCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((UserCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
