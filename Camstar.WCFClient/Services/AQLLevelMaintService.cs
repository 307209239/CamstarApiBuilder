// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AQLLevelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AQLLevelMaintService : NamedDataObjectMaintBase
  {
    public AQLLevelMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAQLLevelMaintService), userProfile);
    }

    public ResultStatus Delete(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).Delete(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((AQLLevelMaint) null, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus Delete(AQLLevelMaint aQLLevelMaint)
    {
      return this.Delete(aQLLevelMaint, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus Delete(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.Delete(aQLLevelMaint, (AQLLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).Freeze(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((AQLLevelMaint) null, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus Freeze(AQLLevelMaint aQLLevelMaint)
    {
      return this.Freeze(aQLLevelMaint, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus Freeze(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.Freeze(aQLLevelMaint, (AQLLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).GetWIPMsgs(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AQLLevelMaint) null, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(AQLLevelMaint aQLLevelMaint)
    {
      return this.GetWIPMsgs(aQLLevelMaint, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.GetWIPMsgs(aQLLevelMaint, (AQLLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).Load(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AQLLevelMaint) null, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus Load(AQLLevelMaint aQLLevelMaint)
    {
      return this.Load(aQLLevelMaint, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus Load(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.Load(aQLLevelMaint, (AQLLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_LoadESigDetails_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).LoadESigDetails(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.LoadESigDetails, (AQLLevelMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AQLLevelMaint) null, (AQLLevelMaint_LoadESigDetails_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(AQLLevelMaint aQLLevelMaint)
    {
      return this.LoadESigDetails(aQLLevelMaint, (AQLLevelMaint_LoadESigDetails_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.LoadESigDetails(aQLLevelMaint, (AQLLevelMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).New(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((AQLLevelMaint) null, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus New(AQLLevelMaint aQLLevelMaint)
    {
      return this.New(aQLLevelMaint, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus New(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.New(aQLLevelMaint, (AQLLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).NewCopy(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((AQLLevelMaint) null, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus NewCopy(AQLLevelMaint aQLLevelMaint)
    {
      return this.NewCopy(aQLLevelMaint, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus NewCopy(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.NewCopy(aQLLevelMaint, (AQLLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).SaveAs(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((AQLLevelMaint) null, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus SaveAs(AQLLevelMaint aQLLevelMaint)
    {
      return this.SaveAs(aQLLevelMaint, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus SaveAs(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.SaveAs(aQLLevelMaint, (AQLLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Parameters parameters,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).UnFreeze(this._UserProfile, aQLLevelMaint, parameters, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(aQLLevelMaint, AQLLevelMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) aQLLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((AQLLevelMaint) null, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus UnFreeze(AQLLevelMaint aQLLevelMaint)
    {
      return this.UnFreeze(aQLLevelMaint, (AQLLevelMaint_Parameters) null, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      AQLLevelMaint aQLLevelMaint,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.UnFreeze(aQLLevelMaint, (AQLLevelMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.Delete((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_LoadESigDetails_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.New((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.Load((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject aQLLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AQLLevelMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AQLLevelMaint) aQLLevelMaint, (AQLLevelMaint_Parameters) parameters, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      try
      {
        AQLLevelMaintMethod[] methods = new AQLLevelMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAQLLevelMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AQLLevelMaint cdo,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      try
      {
        return ((IAQLLevelMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AQLLevelMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((AQLLevelMaint) cdo, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.GetEnvironment((AQLLevelMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AQLLevelMaint cdo,
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      result = (AQLLevelMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAQLLevelMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AQLLevelMaintMethod(cdo, AQLLevelMaintMethods.ExecuteTransaction, (AQLLevelMaint_Parameters) null));
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
        AQLLevelMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AQLLevelMaint) cdo, (AQLLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AQLLevelMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (AQLLevelMaint_Request) null, out AQLLevelMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AQLLevelMaint_Request request,
      out AQLLevelMaint_Result result)
    {
      return this.ExecuteTransaction((AQLLevelMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AQLLevelMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AQLLevelMaintMethod(cdo, AQLLevelMaintMethods.AddDataTransaction, (AQLLevelMaint_Parameters) null));
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
        return this.AddDataTransaction((AQLLevelMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
