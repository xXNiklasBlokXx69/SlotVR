# Unity Oculus Template

Opret et nyt repository med denne template, clone det nye repository til din PC med GitHub Desktop og åben det med Unity Hub.

Herefter skal projektet sætte op til Android/Oculus. Gennemgå denne vejledning nøje:
https://developer.oculus.com/documentation/unity/unity-conf-settings/
(Mange af indstillingerne vil dog være sat, men check dem alligevel)

Lav en branch til hver scene, skift i GitHub Desktop til den branch/scene du skal arbejde med og begynd så at opbygge scenen.

# Probuilder og Polybrush

Se tutorials på:

https://www.procore3d.com/probuilder/

https://docs.unity3d.com/Packages/com.unity.probuilder@5.0/manual/index.html

https://unity.com/features/polybrush

https://docs.unity3d.com/Packages/com.unity.polybrush@1.1/manual/index.html

# Eksporter modeller fra Fusion til Unity

Installer og brug dette plug-in:
[https://apps.autodesk.com/FUSION/en/Detail/Indexid=8887210626238496219&appLang=en&os=Win64]()

Læg materialer på i Fusion – de behøves ikke at være perfekte, da de redigeres i Unity. Navngiv dem!

Kør installeren og eksporter dine Fusion modeller som Unity prefabs.

**HUSK:** 10mm i Fusion svarer til 1 meter i Unity!

**HUSK:** Herefter skal du ’Probuilderize’ det importerede. Så er det klar til at du kan redigere de forskellige materials med nye texturer.

## **Materials**

Find texturer til de materials du har eksporteret fra Fusion her:

[https://polyhaven.com/](https://polyhaven.com/)

## **UV-Mapping**

Herefter skal/kan du UV-mappe materialerne/teksturene:

[ProBuilder Simple Texturing with AutoUVs - YouTube](https://www.youtube.com/watch?v=bigj13SU1rs)

[ProBuilder Advanced Texturing with Manual UVs - YouTube](https://www.youtube.com/watch?v=d3_2h4cN4cY)

## Demo af skift scene

Der ligger to scener i template-projektet, scene1 og scene2. Hvis du bulider projektet med de to scener skal du kunne skifte mellem dem som vist i denne video:

[Demo]([Oculus template skift scene demo - YouTube](https://youtu.be/iY266Y6wQIM))
