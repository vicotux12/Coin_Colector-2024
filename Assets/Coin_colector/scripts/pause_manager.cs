#region Previas
using UnityEngine; 
using System.Collections; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
#endregion
public class pause_manager : MonoBehaviour {
    
	public Canvas canvasPausa;
	
	void Start(){
	canvasPausa.enabled = false;
	Time.timeScale = 1;
	Cursor.visible = false;
	}

	public void scene(string name){
	Time.timeScale=1;	 
	SceneManager.LoadScene (name);
	}
			
	public void Quit(){
     #if UNITY_EDITOR 
    EditorApplication.isPlaying = false;
    #else
    Application.Quit();
	#endif
	}

	#region Pause		
    public void Pause(){
		Cursor.visible = !Cursor.visible;
        canvasPausa.enabled = !canvasPausa.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
		}
	#endregion
	
}